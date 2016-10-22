"use strict";

var React = require('react');
var AccountListItem = require('./accountListItem.jsx');

var AccountList = React.createClass({

    handleItemSelected: function (account) {
        this.props.onItemSelected(account);
    },

    render: function () {

        var createAccountListItem = function (account) {
            return <AccountListItem account={account} key={account.id} onItemSelected={this.handleItemSelected} />;
        }

        return (
            <div className="col-sm-3">
                <div className="panel panel-info">
                    <div className="panel-heading">
                        <h3 className="panel-title">Accounts</h3>
                    </div>
                    <div className="panel-body">
                        <ul className="nav nav-pills nav-stacked">
                            {this.props.accounts.map(createAccountListItem, this)}
                        </ul>
                    </div>
                </div>
            </div>
        );
    }
});

module.exports = AccountList;