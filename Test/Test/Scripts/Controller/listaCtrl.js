// JScript source code
angular.module("listaApp").controller("listaCtrl", function ($scope, $http, $filter, contatosApi) {
    $scope.msg = "Lista de Contatos";
    $scope.contatos = [];
    $scope.operadoras = [];
    carregarContatos();
    carregarOperadoras();

    function carregarContatos() {
        contatosApi.getContatos().success(function (data) {
            $scope.contatos = data;
        });
    };
    function carregarOperadoras() {
        $http.get("http://localhost:50745/api/operadora").success(function (data) {
            $scope.operadoras = data;
        });
    };


    $scope.adicionar = function (contato) {
        contato.data = new Date();
        contatosApi.saveContato(contato).success(function (data) {
            carregarContatos();
            delete $scope.contato;
            $scope.contatoFrom.$setPristine();
        });

    };

    $scope.apagarContatos = function (contatos) {
        $.each(contatos, function (id, contato) {
            if (contato.selecionado) {
                contatosApi.deleteContato(contato.id).success(
                            function () {
                                carregarContatos();
                            }
                        );
            }
        });
    };

    $scope.isSeleceted = function (contatos) {
        return contatos.some(function (contato) {
            if (contato.selecionado) return contato.selecionado;
        });
    };

    $scope.ordenarPor = function (ordenacao) {
        $scope.criteiroOrdenacao = ordenacao;
        $scope.direcaoOrdenacao = !$scope.direcaoOrdenacao;
    }

});