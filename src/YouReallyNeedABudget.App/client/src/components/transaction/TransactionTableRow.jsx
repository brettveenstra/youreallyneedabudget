"use strict";

import React from 'react';

export default class TransactionRow extends React.Component {
    
    constructor(props) {
        super(props);
        this.handleDeleteClick = this.handleDeleteClick.bind(this);
    }

    render() {
        return (
             <tr>
                <td>{this.props.transaction.date}</td>
                <td>{this.props.transaction.payeeName}</td>
                <td>{this.props.transaction.memo}</td>
                <td>{this.props.transaction.amount}</td>
                <td>{this.props.transaction.cleared}</td>
                <td><button onClick={this.handleDeleteClick}>Delete</button></td>
            </tr>
        );
    }

    handleDeleteClick() {
        this.props.onDeleteClicked(this.props.transaction.id);
    }

}

