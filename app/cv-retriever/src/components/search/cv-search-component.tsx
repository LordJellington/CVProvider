import { Component } from "react";
import { InputOnChangeData, SearchBox, SearchBoxChangeEvent } from '@fluentui/react-components';

interface IProps {
    onSearch: (searchTerm: string) => void;
    onClear: () => void;
}

interface IState {
    searchTerm: string;
}

export class CVSearchComponent extends Component<IProps, IState> {

    state: IState = {
        searchTerm: ''
    }

    render() {
        return <SearchBox 
            className="cv-searchbox"
            onKeyUp={this.keyUpHandler} 
            onChange={this.onSearchTermChange}
        />;
    }

    keyUpHandler = (event: React.KeyboardEvent<HTMLInputElement>) => {
        switch (event.code) {
            case 'Enter':
            case 'NumpadEnter':
                this.props.onSearch(this.state.searchTerm);
                break;
        }
    };

    onSearchTermChange = (_: SearchBoxChangeEvent, data: InputOnChangeData) => {
        this.setState({
            searchTerm: data.value
        });

        if (!data.value) {
            this.props.onClear();
        }
    };  

}