import {
  Column,
  Entity,
  Index,
  JoinColumn,
  ManyToOne,
  OneToOne,
} from "typeorm";
import { Account } from "./Account";
import { Plan } from "./Plan";

@Index("plan_account_account_id_key", ["accountId"], { unique: true })
@Index("plan_account_pkey", ["id"], { unique: true })
@Entity("plan_account", { schema: "public" })
export class PlanAccount {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("text", { name: "account_id", unique: true })
  accountId: string;

  @Column("date", { name: "start_date" })
  startDate: string;

  @Column("date", { name: "end_date" })
  endDate: string;

  @OneToOne(() => Account, (account) => account.planAccount)
  @JoinColumn([{ name: "account_id", referencedColumnName: "id" }])
  account: Account;

  @ManyToOne(() => Plan, (plan) => plan.planAccounts)
  @JoinColumn([{ name: "plan_id", referencedColumnName: "id" }])
  plan: Plan;
}
