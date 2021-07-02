import { Column, Entity, Index, OneToMany, OneToOne } from "typeorm";
import { BrokerAccount } from "./BrokerAccount";
import { Payment } from "./Payment";
import { PlanAccount } from "./PlanAccount";
import { TradeRoom } from "./TradeRoom";
import { TradeRoomUser } from "./TradeRoomUser";

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
  authToken: string | null;

  @OneToMany(() => BrokerAccount, (brokerAccount) => brokerAccount.account)
  brokerAccounts: BrokerAccount[];

  @OneToMany(() => Payment, (payment) => payment.account)
  payments: Payment[];

  @OneToOne(() => PlanAccount, (planAccount) => planAccount.account)
  planAccount: PlanAccount;

  @OneToMany(() => TradeRoom, (tradeRoom) => tradeRoom.ownerAccount)
  tradeRooms: TradeRoom[];

  @OneToMany(() => TradeRoomUser, (tradeRoomUser) => tradeRoomUser.account)
  tradeRoomUsers: TradeRoomUser[];
}
