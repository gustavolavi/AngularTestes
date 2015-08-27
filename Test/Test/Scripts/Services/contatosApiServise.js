// JScript source code
angular.module("listaApp").factory("contatosApi", function ($http) {
    var _getContatos = function () {
        return $http.get("http://localhost:50745/api/contato/");
    };

    var _saveContato = function (contato) {
        $http.post("http://localhost:50745/api/contato/", contato)
    };

    var _deleteContato = function (id) {
        return $http.delete("http://localhost:50745/api/contato/"+id);
    };

    return {
        getContatos: _getContatos,
        saveContato: _saveContato,
        deleteContato:_deleteContato
    }
});