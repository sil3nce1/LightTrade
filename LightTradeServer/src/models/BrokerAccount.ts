import {
  BeforeInsert,
  Column,
  Entity,
  Index,
  JoinColumn,
  ManyToOne,
  OneToMany,
} from "typeorm";
import { generateValidModelId } from "../helpers";
import { Account } from "./Account";
import { TradeRoom } from "./TradeRoom";

@Index("broker_account_pkey", ["id"], { unique: true })
@Entity("broker_account", { schema: "public" })
export class BrokerAccount {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("text", { name: "crypted" })
  crypted: string;

  @Column("int", { name: "broker_id" })
  brokerId: number;

  @ManyToOne(() => Account, (account) => account.brokerAccounts)
  @JoinColumn([{ name: "account_id", referencedColumnName: "id" }])
  account: Account;

  @OneToMany(() => TradeRoom, (tradeRoom) => tradeRoom.brokerAccount)
  tradeRooms: TradeRoom[];

  @BeforeInsert()
  async generateId() {
    this.id = await generateValidModelId(BrokerAccount);
  }
}
