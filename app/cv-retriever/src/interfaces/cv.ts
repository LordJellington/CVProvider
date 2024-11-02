import { IEducationalQualification } from "./educational-qualification";
import { IEmploymentHistory } from "./employment-history";

export interface ICV {
    name: string;
    dob: Date;
    skills: string[];
    employmentHistory: IEmploymentHistory[];
    educationalQualifications: IEducationalQualification[];
}