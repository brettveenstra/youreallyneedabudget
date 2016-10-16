"use strict";

var React = require('react');

var AccountListItem = React.createClass({

    onItemSelected: function(){
        this.props.onItemSelected(this.props.account);
    },

    render: function() {
        return (
            <li>
                <a href='#' onClick={this.onItemSelected}>
                {this.props.account.name} {this.props.account.type}
                </a>
            </li>
        );
    }
});

module.exports = AccountListItem;

