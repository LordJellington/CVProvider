import { Component } from "react";
import { ICV } from "../../interfaces";
import { EmploymentHistoryDisplayComponent } from "./employment-history-display";
import { EducationalQualificationsDisplayComponent } from "./educational-qualifications-display";
import { Card } from "@fluentui/react-components";

interface IProps {
    cv?: ICV
}

export class CVDisplayComponent extends Component<IProps> {

    render() {
        return this.props.cv && <Card>
            <ul className="cv-basic-details">
                <li><label>Name:</label> {this.props.cv.name}</li>
                <li><label>Date of Birth:</label> {this.props.cv.dob.toLocaleString('en-GB').split(', ')[0]}</li>
            </ul>
            <h2>Skills</h2>
            <ul className="cv-skills">
                {this.props.cv.skills.map(skill => <li key={skill}>{skill}</li>)}
            </ul>
            <EmploymentHistoryDisplayComponent employmentHistory={this.props.cv.employmentHistory} /> 
            <EducationalQualificationsDisplayComponent educationalQualifications={this.props.cv.educationalQualifications} />
        </Card>;
    }

}