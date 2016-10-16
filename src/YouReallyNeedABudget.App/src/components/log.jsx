"use strict";

var React = require('react');
var AccountList = require('./account/accountList.jsx');
var TransactionTable = require('./account/transactionTable.jsx')

var Log = React.createClass({
    getInitialState: function() {
        return {
            selectedAccount: this.props.accounts[0]
        };
    }, 

   handleAccountListItemSelected: function(account) {
       this.setState({selectedAccount:account})
  },

    render: function() {
        return (
            <div>
                <AccountList accounts={this.props.accounts} onItemSelected={this.handleAccountListItemSelected} />
                <TransactionTable account={this.state.selectedAccount} />
            </div>
        );
    }
});

module.exports = Log;