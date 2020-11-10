# CircleImageDemo
Projet de démonstration pour ma publication concernant la [création d'un contrôle réutilisable compatible MVVM](https://www.sylvainmoingeon.fr/creer-un-controle-reutilisable-100-xamarinforms-partie-1/) : 
Une image circulaire (avec placeholder, indicateur de chargement et bordure colorée) en pur Xamarin.Forms, sans custom renderer ni bibliothèque tierce.

L'article est en deux parties : 

## Partie 1

https://www.sylvainmoingeon.fr/creer-un-controle-reutilisable-100-xamarinforms-partie-1/

* Créer une image circulaire à l'aide de la propriété Clip et des Geometry récemment apparues dans Xamarin.Forms
* Afficher un indicateur d'activité pendant le chargement de l'image
* Afficher une image de substitution en cas d'absence d'image ou d'url invalide en utilisant la technique de superposition dans une Grid
* Afficher une bordure autour de l'image à l'aide des Shape, autre nouveauté de Xamarin.Forms
* Utiliser des fonctionnalités expérimentales avec la version stable actuelle de Xamarin.Forms

## Partie 2

https://www.sylvainmoingeon.fr/creer-un-controle-reutilisable-100-xamarinforms-partie-2/

* Créer un contrôle réutilisable et compatible MVVM :
  * Définir des propriétés bindables (BindableProperty)
  * Utiliser les Converters
  * Et quelques autres astuces ;-)