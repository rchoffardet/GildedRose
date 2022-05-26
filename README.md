# Gilded Rose Refactoring Kata

Bonjour et bienvenue dans l'équipe Gilded Rose. 
Comme vous le savez, nous sommes une petite auberge bien située dans une ville importante, dirigée par une aubergiste sympathique nommée Allison. 
Nous achetons et vendons également les meilleurs produits. 

Malheureusement, la qualité de nos marchandises se dégrade constamment à mesure qu'elles approchent de leur date de péremption. 
Nous avons mis en place un système qui met à jour notre inventaire pour nous. 
Il a été mis au point par un type sérieux nommé Leeroy, qui est parti vers de nouvelles aventures.

Votre tâche consiste à ajouter la nouvelle fonctionnalité à notre système afin que nous puissions commencer à vendre une nouvelle catégorie d'articles.

Tout d'abord, une introduction à notre système :

- Tous les articles ont une valeur `SellIn` qui indique le nombre de jours dont nous disposons pour vendre l'article.
- Tous les articles ont une valeur de qualité qui indique la valeur de l'article.
- À la fin de chaque journée, notre système réduit les deux valeurs pour chaque article.


Plutôt simple, non ? C'est là que ça devient intéressant :

- Une fois la date limite de vente passée, la qualité se dégrade deux fois plus vite.
- La qualité d'un article n'est jamais négative.
- La qualité du "Brie vieilli" augmente au fur et à mesure qu'il vieillit.
- La qualité d'un article n'est jamais supérieure à 50 %.
- Le "Sulfuras", étant un objet légendaire, ne doit jamais être vendu et sa qualité ne diminue jamais.
- Les "laissez-passer pour les coulisses", comme le "brie vieilli", augmentent en qualité à mesure que leur valeur de revente approche; la qualité augmente de 2 lorsqu'il y a 10 jours ou moins et de 3 lorsqu'il y a 5 jours ou moins, mais la qualité tombe à 0 après le concert.

Nous avons récemment signé avec un fournisseur d'articles "magiques". Cela nécessite une mise à jour de notre système :

- Les articles "magiques" se dégradent en qualité deux fois plus vite que les articles normaux.

N'hésitez pas à modifier la méthode `UpdateQuality` et à ajouter du nouveau code, tant que tout fonctionne correctement. 
Cependant, ne modifiez pas la classe ou la propriété des objets car elles appartiennent au gobelin du coin qui va se mettre en colère et vous tirer dessus car il ne croit pas à la propriété partagée du code (vous pouvez rendre la méthode `UpdateQuality` et la propriété des objets statiques si vous le souhaitez).

Pour clarifier les choses, la qualité d'un objet ne peut jamais dépasser 50, mais "Sulfuras" est un objet légendaire et, en tant que tel, sa qualité est de 80 et il ne change jamais.

## Getting started

- Installer le [SDK dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Installer l'extension [C# pour VScode](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
  - Activer [l'option ".NET moderne"](https://www.strathweb.com/2022/01/hello-omnisharp-on-net-6-0/)
- Se déplacer dans le projet de test : `cd tests`
- Lancer l'exécution des tests en live `dotnet watch test`
- Enjoy !


## En savoir plus

Qui : [@TerryHughes](https://twitter.com/TerryHughes), [@NotMyself](https://twitter.com/NotMyself)

Quoi et pourquoi : [Refactor This : The Gilded Rose Kata](http://iamnotmyself.com/2011/02/13/refactor-this-the-gilded-rose-kata/)

## Licence

MIT

## Attribution suggérée

Ce travail est réalisé par [@TerryHughes](https://twitter.com/TerryHughes), [@NotMyself](https://twitter.com/NotMyself)

Le référentiel se trouve à l'adresse [https://github.com/NotMyself/GildedRose](https://github.com/NotMyself/GildedRose)
