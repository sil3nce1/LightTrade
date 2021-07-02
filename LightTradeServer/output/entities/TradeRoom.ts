import {
  Column,
  Entity,
  Index,
  JoinColumn,
  ManyToOne,
  OneToMany,
} from "typeorm";
import { Account } from "./Account";
import { TradeRoomUser } from "./TradeRoomUser";

@Index("trade_room_pkey", ["id"], { unique: true })
@Entity("trade_room", { schema: "public" })
export class TradeRoom {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("text", { name: "broker_account_id" })
  brokerAccountId: string;

  @Column("integer", { name: "wins", default: () => "0" })
  wins: number;

  @Column("integer", { name: "losses", default: () => "0" })
  losses: number;

  @ManyToOne(() => Account, (account) => account.tradeRooms)
  @JoinColumn([{ name: "owner_account_id", referencedColumnName: "id" }])
  ownerAccount: Account;

  @OneToMany(() => TradeRoomUser, (tradeRoomUser) => tradeRoomUser.tradeRoom)
  tradeRoomUsers: TradeRoomUser[];
}
