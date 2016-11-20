import axios from 'axios';

export default class BudgetAPI {
 
    static getAccounts() {
        return axios.get("http://localhost:5000/api/accounts");
    }

    static addTransaction(transaction) {
        return axios.post("http://localhost:5000/api/transactions", transaction);
    }

    static deleteTransaction(transactionId) {
        return axios.delete("http://localhost:5000/api/transactions/" + transactionId);
    }
}