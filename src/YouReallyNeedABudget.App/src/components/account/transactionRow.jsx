"use strict";

var React = require('react');

var TransactionRow = React.createClass({
    render: function() {

        return (
             <tr>
                <td>{this.props.transaction.date}</td>
                <td>{this.props.transaction.payeeName}</td>
                <td>{this.props.transaction.memo}</td>
                <td>{this.props.transaction.amount}</td>
                <td>{this.props.transaction.cleared}</td>
            </tr>
        );
    }
});

module.exports = TransactionRow;

