# ULMClubManager

## Etapes prévues

*	Construire le MLD à partir du MCD de la page 3 du Doc 4.
    * Reproduire le MCD dans JMerise
    * Récupérer les scripts de création et les copier dans le fichier texte "creationDB" dans le fichier "scripts"
    * Récupérer ou générer les données référentielles (240 membres fin mars 2021).

## Installation base de données

* Créer une nouvelle base de données avec le nom "**ULMClubManager**".
* Exécuter le script [creationDB](./scripts/creationDB.sql).

## Information de connexion locale

* Source de données = Microsoft SQL Server 2019 (SqlClient)
* Nom du serveur = localhost
* Authentification = Authentification SQL Server
  * Nom d'utilisateur = sa
  * Mot de passe = <YourStrong@Passw0rd>