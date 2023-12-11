angular.module('GestorPersonagem')
    .controller('PersonagemController', function ($scope) {

    $scope.personagens = [
        {
            Nome:'Kazuha',
            Nivel:'90',
            Classe:'Bateria',
            Constelacao:'C0',
            Golpe:'1',
            Habilidade:'10',
            Ultimate:'7',
            Visao: 'Anemo',
            ATK:'100',
            DEF:'200',
            HP: '300',
            ElementalMastery: '100',
            EnergyRecharge: '500',
            CritHate: '100%',
            CritDMG: '400%'
        },
        {
            Nome: 'Itto',
            Nivel: '90',
            Classe: 'DPS',
            Constelacao: 'C0',
            Golpe: '10',
            Habilidade: '8',
            Ultimate: '10',
            Visao: 'Geo',
            ATK: '200',
            DEF: '300',
            HP: '100',
            ElementalMastery: '400',
            EnergyRecharge: '600',
            CritHate: '100%',
            CritDMG: '100%'
        },
        {
            Nome: 'Zhongli',
            Nivel: '90',
            Classe: 'Escudo',
            Constelacao: 'C0',
            Golpe: '1',
            Habilidade: '8',
            Ultimate: '8',
            Visao: 'Geo',
            ATK: '100',
            DEF: '200',
            HP: '300',
            ElementalMastery: '400',
            EnergyRecharge: '500',
            CritHate: '600%',
            CritDMG: '700%'
        }
        ];

        $scope.verDetalhes = function (personagem) {
            // Redirecionar para a página de detalhes com base no ID ou outro identificador único do personagem
            // Aqui você pode usar um serviço de roteamento do AngularJS, como $location.path() ou $state.go()
            // Passando o ID ou outras informações necessárias para a página de detalhes
            // Exemplo (considerando que você tenha um ID para cada personagem):
            $location.path('/detalhes/' + personagem.Id); // Substitua 'Id' pelo identificador real do personagem
        };

        $scope.editarPersonagem = function (personagem) {
            // Redirecionar para a página de edição com base no ID ou outro identificador único do personagem
            // Da mesma forma, use o serviço de roteamento do AngularJS para redirecionar para a página de edição
            $location.path('/editar/' + personagem.Id); // Substitua 'Id' pelo identificador real do personagem
        };


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



