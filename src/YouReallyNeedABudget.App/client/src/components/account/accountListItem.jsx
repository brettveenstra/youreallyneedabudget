import React from 'react';

export default class AccountListItem extends React.Component {

    constructor(props) {
        super(props);
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.props.onSelected(this.props.account.id);
    }

    render() {
        return <li><a href="#" onClick={this.handleClick}>{this.props.account.name}</a></li>;
    }
}
