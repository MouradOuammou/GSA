# Système de Gestion Administrative RH

## Description
Cette application desktop développée en C# .NET permet de gérer efficacement les situations administratives des employés. Elle utilise SQL Server LocalDB comme base de données locale pour un déploiement simplifié.

## Fonctionnalités principales
- Gestion complète des dossiers employés
- Suivi des situations administratives
- Interface utilisateur conviviale avec menus personnalisables
- Gestion des documents administratifs
- Système de reporting et d'exportation de données
- Impression des documents via DGVPrinter

## Prérequis techniques
- Microsoft .NET Framework (version recommandée : 4.7.2 ou supérieure)
- SQL Server LocalDB (inclus avec Visual Studio)
- Windows 7 ou version ultérieure
- Visual Studio 2019 ou version ultérieure (pour le développement)

## Installation
1. Assurez-vous que LocalDB est installé (inclus avec Visual Studio)
2. Clonez le repository
3. Ouvrez la solution dans Visual Studio
4. Dans l'explorateur de solutions, double-cliquez sur le fichier `.sln`
5. Restaurez les packages NuGet
6. La base de données sera automatiquement créée au premier lancement

## Structure du projet
```
├── bin/                  # Fichiers binaires
├── Content/             # Contenu statique
├── fonts/              # Polices personnalisées
├── Forms/              # Formulaires de l'application
├── GunaUIKeygen/      # Composants UI personnalisés
├── Properties/        # Propriétés du projet
├── Resources/        # Ressources de l'application
├── App.config        # Configuration de l'application et chaîne de connexion LocalDB
├── DateTime.cs      # Gestion des dates
├── DGVPrinter.cs   # Module d'impression
├── Functions.cs    # Fonctions utilitaires
├── Menu.cs        # Gestion des menus
└── Program.cs    # Point d'entrée de l'application
```

## Configuration de LocalDB
La chaîne de connexion dans `App.config` devrait ressembler à ceci :
```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NomDeVotreBase.mdf;Integrated Security=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Utilisation
1. Lancez l'application
2. Le système créera automatiquement la base de données si elle n'existe pas
3. Utilisez le menu principal pour accéder aux fonctionnalités:
   - Gestion des employés
   - Suivi administratif
   - Génération de documents
   - Reporting

## Développement
Pour contribuer au développement:
1. Assurez-vous que LocalDB est correctement configuré
2. Vérifiez que la chaîne de connexion pointe vers le bon fichier .mdf
3. Suivez les conventions de code C#
4. Testez vos modifications localement

## Maintenance
- Sauvegardez régulièrement le fichier .mdf de la base de données
- Vérifiez l'espace disque disponible pour LocalDB
- Maintenez Visual Studio et LocalDB à jour

## Support
Pour toute assistance:
- Vérifiez que LocalDB est correctement installé
- Consultez la documentation technique
- Vérifiez les logs d'erreur dans le dossier de l'application

## Licence
Droits réservés - Usage interne uniquement

## Notes de version
Version actuelle : 1.0.0
- Interface utilisateur avec Guna UI
- Système de gestion documentaire intégré
- Base de données LocalDB pour une installation simplifiée
