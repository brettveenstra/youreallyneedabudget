"use strict";

var React = require('react');
var TransactionRow = require('./transactionRow.jsx');
var AddTransactionRowForm = require('./addTransactionRowForm.jsx');

var TransactionTable = React.createClass({
    render: function () {

        var createTransactionRow = function (tx) {
            return <TransactionRow transaction={tx} key={tx.id} />;
        }

        return (
            <div className="col-sm-9">
                <div className="panel panel-primary">

                    <div className="panel-heading">
                        <h3 className="panel-title">Transactions</h3>
                    </div>
                    <div className="panel-body">
                        <table className="table table-hover">
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
                         <AddTransactionRowForm account={this.props.account} />
                    </div>
                </div>
            </div>
        );
    }
});

module.exports = TransactionTable;