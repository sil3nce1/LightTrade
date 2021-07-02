import { Column, Entity, Index, JoinColumn, ManyToOne } from "typeorm";
import { Account } from "./Account";

@Index("broker_account_pkey", ["id"], { unique: true })
@Entity("broker_account", { schema: "public" })
export class BrokerAccount {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("text", { name: "crypted" })
  crypted: string;

  @Column("integer", { name: "broker_id" })
  brokerId: number;

  @ManyToOne(() => Account, (account) => account.brokerAccounts)
  @JoinColumn([{ name: "account_id", referencedColumnName: "id" }])
  account: Account;
}
