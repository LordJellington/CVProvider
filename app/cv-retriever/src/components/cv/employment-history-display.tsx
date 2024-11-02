import { Component } from "react";
import { IEmploymentHistory } from "../../interfaces";
import { DateHelper } from "../../helpers/date-helper";
import { Accordion, AccordionHeader, AccordionItem, AccordionPanel } from "@fluentui/react-components";

interface IProps {
    employmentHistory: IEmploymentHistory[]
}

export class EmploymentHistoryDisplayComponent extends Component<IProps> {

    render() {
        return <div>
            <h2>Employment History</h2>
            <Accordion collapsible={true} multiple={true}>
                {this.props.employmentHistory.map((eh, i) => {
                    return <AccordionItem key={eh.jobTitle + '_' + eh.employer} value={i}>
                        <AccordionHeader><h3>{eh.jobTitle}, {eh.employer}</h3></AccordionHeader>
                        <AccordionPanel>
                            <div>{DateHelper.formatDate(eh.startDate)} - {DateHelper.formatDate(eh.endDate)}</div>
                            <div dangerouslySetInnerHTML={{ __html: eh.description }}></div>
                        </AccordionPanel>
                    </AccordionItem>
                })}
            </Accordion>
        </div>;
    }

}