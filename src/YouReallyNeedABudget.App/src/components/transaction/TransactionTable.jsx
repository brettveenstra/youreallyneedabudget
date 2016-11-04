import React from 'react';
import TransactionTableRow from './TransactionTableRow.jsx';

export default class TransactionTable extends React.Component {

    createTableRows(account) {
        if (account) {
            return account.transactions.map((tx) => <TransactionTableRow transaction={tx} key={tx.id} onDeleteClicked={this.props.onDeleteTransactionClicked} />);
        }
    }

    render() {
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
                                {this.createTableRows(this.props.account)}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        );
    }
}