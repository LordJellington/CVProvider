import { IEmploymentHistory, IEducationalQualification } from "../interfaces";
import { ICVRetrieverResponse } from "../interfaces/cv-retriever-response";

export const cvRequestHandler = async(name: string): Promise<ICVRetrieverResponse> =>  {
    return fetch('http://localhost:7071/api/GetCV?name=' + name)
        .then(response => response && response.status === 200 ? response.json() : null)
        .then(jsonResponse => {

            if (!jsonResponse) {
                return {
                    message: `Cannot find a CV for ${name}`
                }
            }

            return {
                message: `Found a CV for ${name}`,
                cv: {
                    name: jsonResponse['name'],
                    dob: new Date(jsonResponse['dob']),
                    skills: jsonResponse['skills'],
                    employmentHistory: jsonResponse['employmentHistory']
                        .map((employmentHistory: IEmploymentHistory) => {
                            return {
                                ...employmentHistory,
                                startDate: new Date(employmentHistory.startDate),
                                endDate: new Date(employmentHistory.endDate)
                            };
                        }),
                    educationalQualifications: jsonResponse['educationalQualifications']
                        .map((educationalQualification: IEducationalQualification) => {
                            return {
                                ...educationalQualification,
                                startDate: new Date(educationalQualification.startDate),
                                endDate: new Date(educationalQualification.endDate)
                            };
                        })
                }
            };
        });
};