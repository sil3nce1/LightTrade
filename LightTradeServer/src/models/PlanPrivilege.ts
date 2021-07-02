import { Column, Entity, Index, JoinColumn, ManyToOne } from "typeorm";
import { Plan } from "./Plan";

@Index("plan_privilege_pkey", ["id"], { unique: true })
@Entity("plan_privilege", { schema: "public" })
export class PlanPrivilege {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("integer", { name: "privilege" })
  privilege: number;

  @ManyToOne(() => Plan, (plan) => plan.planPrivileges)
  @JoinColumn([{ name: "plan_id", referencedColumnName: "id" }])
  plan: Plan;
}
