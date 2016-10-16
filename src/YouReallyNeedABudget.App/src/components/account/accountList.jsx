"use strict";

var React = require('react');
var AccountListItem = require('./accountListItem.jsx');

var AccountList = React.createClass({

    handleItemSelected: function(account) {
        this.props.onItemSelected(account);
    },

    render: function () {

        var createAccountListItem = function(account){
            return <AccountListItem account={account} key={account.id} onItemSelected={this.handleItemSelected}  />;
        }

        return (
            <div>
                <h2>Accounts</h2>
                <ul>  
                    {this.props.accounts.map(createAccountListItem, this)}
                </ul>
            </div>
        );
    }
});

module.exports = AccountList;