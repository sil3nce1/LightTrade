import { Column, Entity, Index, JoinColumn, ManyToOne } from "typeorm";
import { Account } from "./Account";
import { TradeRoom } from "./TradeRoom";

@Index("trade_room_user_pkey", ["id"], { unique: true })
@Entity("trade_room_user", { schema: "public" })
export class TradeRoomUser {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @ManyToOne(() => Account, (account) => account.tradeRoomUsers)
  @JoinColumn([{ name: "account_id", referencedColumnName: "id" }])
  account: Account;

  @ManyToOne(() => TradeRoom, (tradeRoom) => tradeRoom.tradeRoomUsers)
  @JoinColumn([{ name: "trade_room_id", referencedColumnName: "id" }])
  tradeRoom: TradeRoom;
}
