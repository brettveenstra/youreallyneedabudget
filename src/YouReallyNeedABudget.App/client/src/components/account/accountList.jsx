import React from 'react';
import AccountListItem from './AccountListItem.jsx';

export default class AccountList extends React.Component {

    render() {
        return (
            <div className="col-sm-3">
                <div className="panel panel-info">
                    <div className="panel-heading">
                        <h3 className="panel-title">Accounts</h3>
                    </div>
                    <div className="panel-body">
                        <ul className="nav nav-pills nav-stacked">{this.props.accounts.map((account) => <AccountListItem account={account} onSelected={this.props.onItemSelected} key={account.name} />)}</ul>
                    </div>
                </div>
            </div>
        );
    }
}
