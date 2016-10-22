"use strict";

var React = require('react');

var AddTransactionRowForm = React.createClass({

    getInitialState: function() {
        return {date: '', payee: '', memo: '', amount: '', cleared: false};
    },

    handleDateChange: function (e) {
        this.setState({date: e.target.value});
    },

    handlePayeeChange: function (e) {
        this.setState({payee: e.target.value});
    },

    handleMemoChange: function (e) {
        this.setState({memo: e.target.value});
    },

    handleAmountChange: function (e) {
        this.setState({amount: e.target.value});
    },

    handleClearedChange: function (e) {
        this.setState({cleared: e.target.checked})
    },

    handleSubmit: function (e) {
        e.preventDefault();
        var transaction = {
            accountid: this.props.account.id,
            date: this.state.date.trim(),
            memo: this.state.memo.trim(),
            amount: this.state.amount.trim(),
            cleared: this.state.cleared
        }
        
        // TODO: send request to the server
        this.setState({ date: '', memo: '', amount: '', cleared: false });
    },

    render: function() {

        return (
            <form className="form-inline" onSubmit={this.handleSubmit}>
                    <input type="date" className="form-control" name="date" onChange={this.handleDateChange} placeholder="Date" value={this.state.date} />
                    <input type="text" className="form-control" name="payee" onChange={this.handlePayeeChange} placeholder="Payee" value={this.state.payee} />
                    <input type="text" className="form-control" name="memo" onChange={this.handleMemoChange} placeholder="Memo" value={this.state.memo} />
                    <input type="text" className="form-control" name="amount" onChange={this.handleAmountChange} placeholder="Amount" value={this.state.amount} />
                    <input type="checkbox" className="form-control" name="cleared" onChange={this.handleClearedChange} checked={this.state.cleared} />
                    <input type="submit" className="btn btn-default" value="Save" />
            </form>
        );
    }
});

module.exports = AddTransactionRowForm;