import { Column, Entity, Index, JoinColumn, ManyToOne } from "typeorm";
import { Plan } from "./Plan";

@Index("plan_item_pkey", ["id"], { unique: true })
@Entity("plan_item", { schema: "public" })
export class PlanItem {
  @Column("text", { primary: true, name: "id" })
  id: string;

  @Column("character varying", { name: "item", length: 255 })
  item: string;

  @ManyToOne(() => Plan, (plan) => plan.planItems)
  @JoinColumn([{ name: "plan_id", referencedColumnName: "id" }])
  plan: Plan;
}
