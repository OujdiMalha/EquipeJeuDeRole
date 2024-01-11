# EquipeJeuDeRole
Membres : Mohammed - Fabrice - Virgile – Nathan


Diagramme de classe : (voir dans le dossier)




Notre jeu de rôle développé avec Blazor WebAssembly en C#.

Boutons principaux :

o La page affiche un titre "Jeu de rôle" et propose un bouton "Nouvelle Partie" qui, lorsqu'il est cliqué, appelle la méthode NouvellePartie.

o  Bouton de navigation navigation vers d'autres pages telles que "Plateau" et "ZoneCombat". Ce bouton peuvent être utilisés pour diriger le joueur vers différentes sections du jeu, après avoir créé son personnage.


Options supplémentaires :

o La page propose également des boutons pour charger une partie précédemment sauvegardée et quitter le jeu.

Fonctions associées :


o La méthode NouvellePartie est responsable de la suppression des données de l'état de la page (sauvegardées localement) et de la navigation vers la page de création de personnage.
o La méthode ChoisirPersonnage serait  utilisée pour la logique de choix du personnage (Guerrier, Sorcier, Archer).
o La méthode ChargerPartie  serait probablement utilisée pour charger une partie sauvegardée et naviguer vers la page du plateau de jeu.
o Les méthodes AfficherOptions et ModifierParametre est réservées pour des fonctionnalités futures liées à l'affichage des options et à la modification des paramètres du jeu.
o La méthode Quitter est réservée pour la logique de quitter le jeu.
