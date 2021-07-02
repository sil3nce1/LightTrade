import { BeforeInsert, Column, Entity, Index, JoinColumn, ManyToOne } from "typeorm";
import { PaymentStatusEnum } from "../enums/PaymentStatusEnum";
import { getDaysDifference } from "../helpers";
import { Account } from "./Account";
import { Coupon } from "./Coupon";
import { Plan } from "./Plan";

@Index("payment_pkey", ["id"], { unique: true })
@Entity("payment", { schema: "public" })
export class Payment {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("double precision", { name: "price", nullable: true, precision: 53 })
  price: number | null;

  @Column("character varying", { name: "platform", length: 255 })
  platform: string;

  @Column("integer", { name: "status", default: () => "0" })
  status: number;

  @Column("date", { name: "start_date" })
  startDate: Date;

  @ManyToOne(() => Account, (account) => account.payments, { eager: true })
  @JoinColumn([{ name: "account_id", referencedColumnName: "id" }])
  account: Account;

  @ManyToOne(() => Coupon, (coupon) => coupon.payments, { eager: true })
  @JoinColumn([{ name: "coupon_id", referencedColumnName: "id" }])
  coupon: Coupon;

  @ManyToOne(() => Plan, (plan) => plan.payments, { eager: true })
  @JoinColumn([{ name: "plan_id", referencedColumnName: "id" }])
  plan: Plan;

  @BeforeInsert()
  format() {
    this.startDate = new Date();
  }


  isValid(): boolean {
    const startDate = new Date(this.startDate);
    return getDaysDifference(new Date(), startDate) < 2 && this.status != PaymentStatusEnum.OPEN;
  }
}
