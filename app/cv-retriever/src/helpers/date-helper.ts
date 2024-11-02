import { format } from "date-fns";

export class DateHelper {
    public static formatDate(dateToFormat: Date) {
        return format(dateToFormat, "MMM yyyy");
    }
}