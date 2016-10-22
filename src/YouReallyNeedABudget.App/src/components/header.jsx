"use strict";

var React = require('react');

var Header = React.createClass({
    render: function() {
        return (
            <div className="page-header">
                <h1>YouReallyNeedABudget &nbsp;
                <small>A simple budgeting tool built with ASP.NET Core and React.</small>
                </h1>
            </div>
        );
    }
});

module.exports = Header;