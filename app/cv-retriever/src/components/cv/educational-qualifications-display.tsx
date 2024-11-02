import { Component } from "react";
import { IEducationalQualification } from "../../interfaces";
import { DateHelper } from "../../helpers/date-helper";
import { Accordion, AccordionHeader, AccordionItem, AccordionPanel } from "@fluentui/react-components";

interface IProps {
    educationalQualifications: IEducationalQualification[]
}

export class EducationalQualificationsDisplayComponent extends Component<IProps> {

    render() {
        return <div>
            <h2>Educational Qualifications</h2>
            <Accordion collapsible={true} multiple={true}>
            {this.props.educationalQualifications.map((eq, i) => {
                return <AccordionItem key={eq.courseName + '_' + eq.establishment} value={i}>
                        <AccordionHeader><h3>{eq.courseName}, {eq.establishment}</h3></AccordionHeader>
                        <AccordionPanel>
                        <div>{DateHelper.formatDate(eq.startDate)} - {DateHelper.formatDate(eq.endDate)}</div>
                        </AccordionPanel>
                    </AccordionItem>
            })}
            </Accordion>
        </div>;
    }

}