import { EntityTarget, getRepository } from "typeorm";
import { v4 as uuid } from "uuid";
import { BrokerEnum } from "../enums/BrokerEnum";




export async function generateValidModelId<T>(model: EntityTarget<T>) {
    const modelRepository = getRepository(model);
    let id = uuid();
    while (await modelRepository.findOne(id)) {
        id = uuid();
    }
    return id;
}

export function calculatePercentage(percentage: number, total: number): number {
    return percentage * total / 100;
}

export async function brokerIdToStr(brokerId: BrokerEnum) {
    if (brokerId == BrokerEnum.IQOPTION)
        return "IQOPTION";
    else if (brokerId == BrokerEnum.EBINEX)
        return "EBINEX";
    else if (brokerId == BrokerEnum.XTB)
        return "XTB";
}


export function addDays(date: Date, days: number): Date {
    const copy = new Date(Number(date));
    copy.setDate(date.getDate() + days);
    return copy;
}

export function getDaysDifference(date1: Date, date2: Date) {
    const differenceInTime = date1.getTime() - date2.getTime();
    return differenceInTime / (1000 * 3600 * 24);
}