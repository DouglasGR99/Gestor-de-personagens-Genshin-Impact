angular.module('GestorPersonagem')
    .controller('PersonagemController', function ($scope) {
        var app = angular.module('app', []);
        app.controller('MainCtrl', function ($scope) {
            $scope.personagemes = [
                {
                    Nome:
                    Nível:
                    Classe:
                    Constelação:
                    Golpe:
                    Habilidade:
                    Ultimate:
                    Visão:
                },
            ];
            $scope.personagemEditado = {}; // Objeto para armazenar os dados do personagem em edição

            $scope.editarPersonagem = function () {
                // Aqui você pode adicionar a lógica para salvar as alterações
                console.log("Dados do personagem editados:", $scope.personagemEditado);
                // Limpar o objeto de edição após salvar as alterações
                $scope.personagemEditado = {};
            };


            $scope.selecionarPersonagem = function (personagem) {
                $scope.personagemEditado = angular.copy(personagem);
            };
        });
    };