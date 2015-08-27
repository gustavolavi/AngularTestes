// JScript source code

myApp.controller('EnredecoController', ['$scope','$http', function ($scope,$http) {

   $scope.enderecos =[{}];
    $http.get("http://localhost:50745/api/values").success(function (response) {
        $scope.enderecos = getAll(response);
    });
    
    $scope.enderecoId =function(id)
    {
        if(id>0)
        {
            for(i=0;i<$scope.enderecos.length;i++)
            {
                var aux = $scope.enderecos[i];
                if(aux.id == id)
                {
                    return aux;
                }
            }
        }
    }

function getAll(e)
    {
        var returno=[];
        for(i=0;i<e.length;i++)
        {
            var endereco = new Endereco(e[i].Id,e[i].UF,e[i].Estado,e[i].Bairro,e[i].Rua,e[i].Numero);
            returno.push(endereco);
        } 
        return returno;
    } 

function Endereco(id,uf,estado,bairro,rua,numero)
{
    this.id = id;
    this.uf = uf;
    this.estado = estado;
    this.bairro = bairro;
    this.rua = rua;
    this.numero = numero;
}
}]);


