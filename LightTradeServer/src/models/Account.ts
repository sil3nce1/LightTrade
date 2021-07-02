import { BeforeInsert, BeforeUpdate, Column, Entity, Index, OneToMany, OneToOne } from "typeorm";
import { generateValidModelId, getDaysDifference } from "../helpers";
import { BrokerAccount } from "./BrokerAccount";
import { PlanAccount } from "./PlanAccount";
import { TradeRoom } from "./TradeRoom";
import { TradeRoomUser } from "./TradeRoomUser";
import * as bcryptjs from "bcryptjs";
import { Payment } from "./Payment";

const freePlan = process.env.FREE_PLAN == 'true' ? true : false;


@Index("account_email_key", ["email"], { unique: true })
@Index("account_pkey", ["id"], { unique: true })
@Index("account_username_key", ["username"], { unique: true })
@Entity("account", { schema: "public" })
export class Account {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("character varying", { name: "username", unique: true, length: 15 })
  username: string;

  @Column("character varying", { name: "email", unique: true, length: 255 })
  email: string;

  @Column("text", { name: "password" })
  password: string;

  @Column("boolean", { name: "is_banned", default: () => "false" })
  isBanned: boolean;

  @Column("character varying", {
    name: "ban_reason",
    nullable: true,
    length: 255,
  })
  banReason: string | null;

  @Column("boolean", { name: "is_trader", default: () => "false" })
  isTrader: boolean;

  @Column("boolean", { name: "is_admin", default: () => "false" })
  isAdmin: boolean;

  @Column("boolean", { name: "is_email_confirmed", default: () => "false" })
  isEmailConfirmed: boolean;

  @Column("text", { name: "auth_token", nullable: true })
  authToken: string;

  @OneToMany(() => BrokerAccount, (brokerAccount) => brokerAccount.account)
  brokerAccounts: BrokerAccount[];

  @OneToOne(() => PlanAccount, (planAccount) => planAccount.account, { eager: true })
  planAccount: PlanAccount;

  @OneToMany(() => TradeRoom, (tradeRoom) => tradeRoom.ownerAccount)
  tradeRooms: TradeRoom[];

  @OneToMany(() => TradeRoomUser, (tradeRoomUser) => tradeRoomUser.account)
  tradeRoomUsers: TradeRoomUser[];

  @OneToMany(() => Payment, (payment) => payment.account)
  payments: Payment[];


  @BeforeInsert()
  async generateId() {
    this.id = await generateValidModelId(Account);
  }

  @BeforeInsert()
  @BeforeUpdate()
  format() {
    this.email = this.email.toLowerCase();
    this.password = bcryptjs.hashSync(this.password, Number.parseInt(process.env.HASH_SALT));
  }

  hasPlan(): boolean {
      if (freePlan)
        return true;

      if ((this.isAdmin) || (this.isTrader))
        return true;

      if (this.planAccount == null)
        return false;

      if (this.planAccount.endDate == null)
      return false;

      const endDate = new Date(this.planAccount.endDate);

      return endDate > new Date();
  }

  getPlanRemainingTime(): number {
    if ((this.hasPlan()) && (!freePlan)) {
      const endDate = new Date(this.planAccount.endDate);
      return Math.round(getDaysDifference(endDate, new Date())) + 1;
    }

    return 0;
  }
}
