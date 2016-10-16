"use strict";

var React = require('react');
var TransactionRow = require('./transactionRow.jsx');

var TransactionTable = React.createClass({
    render: function () {

        var createTransactionRow = function(tx){
            return <TransactionRow transaction={tx} key={tx.id} />;
        }

        return (
            <div>
                <h2>Transactions</h2>
                <table>
                    <thead>
                        <tr>
                            <td>Date</td>
                            <td>Payee</td>
                            <td>Memo</td>
                            <td>Amount</td>
                            <td>Cleared</td>
                        </tr>
                    </thead>
                    <tbody>
                        {this.props.account.transactions.map(createTransactionRow)}
                    </tbody>
                </table>
            </div>
        );
    }
});

module.exports = TransactionTable;