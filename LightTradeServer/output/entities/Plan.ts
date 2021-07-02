import { Column, Entity, Index, OneToMany } from "typeorm";
import { Payment } from "./Payment";
import { PlanAccount } from "./PlanAccount";
import { PlanItem } from "./PlanItem";
import { PlanPrivilege } from "./PlanPrivilege";

@Index("plan_pkey", ["id"], { unique: true })
@Index("plan_name_key", ["name"], { unique: true })
@Entity("plan", { schema: "public" })
export class Plan {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("character varying", { name: "name", unique: true, length: 255 })
  name: string;

  @Column("character varying", { name: "description", length: 255 })
  description: string;

  @Column("double precision", {
    name: "price",
    precision: 53,
    default: () => "0",
  })
  price: number;

  @Column("integer", { name: "days" })
  days: number;

  @OneToMany(() => Payment, (payment) => payment.plan)
  payments: Payment[];

  @OneToMany(() => PlanAccount, (planAccount) => planAccount.plan)
  planAccounts: PlanAccount[];

  @OneToMany(() => PlanItem, (planItem) => planItem.plan)
  planItems: PlanItem[];

  @OneToMany(() => PlanPrivilege, (planPrivilege) => planPrivilege.plan)
  planPrivileges: PlanPrivilege[];
}
