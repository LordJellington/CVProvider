import React, { Component } from 'react';
import { CVSearchComponent } from './search/cv-search-component';
import { cvRequestHandler } from '../request-handlers/cv-request-handler';
import { ICVRetrieverResponse, ICV } from '../interfaces';
import { CVDisplayComponent } from './cv/cv-display';

interface IState {
    message: string, 
    cv?: ICV
};

class CVRetrieverComponent extends Component<{}, IState> {

    private readonly _defaultState: IState = {
        message: '', 
        cv: undefined
    }

    state: IState = this._defaultState;

    render() {
        return <div className='cv-retriever'>
            <h1>CV Retriever</h1>
            <CVSearchComponent 
                onSearch={this.onSearch} 
                onClear={this.onClear}
            />
            {this.state.message && <h3>{ this.state.message }</h3>}
            <CVDisplayComponent cv={ this.state.cv } />
        </div>;
    }

    onSearch = (searchTerm: string) => {
        cvRequestHandler(searchTerm).then((result: ICVRetrieverResponse) => {
            this.setState({
                cv: result.cv,
                message: result.message
            });
        });
    }

    onClear = () => {
        this.setState(this._defaultState);
    }
}

export default CVRetrieverComponent;