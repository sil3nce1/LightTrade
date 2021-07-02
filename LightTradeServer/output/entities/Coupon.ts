import { Column, Entity, Index, OneToMany } from "typeorm";
import { Payment } from "./Payment";

@Index("coupon_code_key", ["code"], { unique: true })
@Index("coupon_pkey", ["id"], { unique: true })
@Entity("coupon", { schema: "public" })
export class Coupon {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("character varying", { name: "code", unique: true, length: 255 })
  code: string;

  @Column("double precision", {
    name: "percentage",
    nullable: true,
    precision: 53,
  })
  percentage: number | null;

  @Column("integer", { name: "max_uses", default: () => "0" })
  maxUses: number;

  @Column("integer", { name: "uses", default: () => "0" })
  uses: number;

  @OneToMany(() => Payment, (payment) => payment.coupon)
  payments: Payment[];
}
