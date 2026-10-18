# 🚀 Asteroids 2D

Projecte desenvolupat en **Unity 2D** per a l'assignatura de *Programació de Videojocs 2D i 3D* de l'**Institut Tecnològic de Barcelona (ITB)**.

El joc és una versió del clàssic *Asteroids*: la nau se situa al centre de la pantalla rotant cap a la posició del cursor del ratolí i disparant projectils per defensar-se d'd'onades d'asteroides de diferents mides.

---

## 🎮 Característiques del Joc

* **Nau i Controls:** Implementats fent servir el **New Input System** d'Unity mitjançant classes C# generades (`ISpaceShipActions`).
* **Object Pooling:** Optimització de rendiment mitjançant `Stack<T>` per a la gestió eficient de bales (`BulletPool`) i asteroides (`AsteroidPool`), evitant crides contínues a `Instantiate()` o `Destroy()`.
* **Disseny Modular:** Ús de **ScriptableObjects** (`AsteroidData`) per definir els 3 tipus d'asteroides (*Gran*, *Mitjà* i *Petit*) sobre un únic Prefab base.
* **Físiques i Col·lisions 2D:** Gestió de col·lisions en mode *Trigger* amb `Rigidbody2D` dinàmic i sense gravetat (`Gravity Scale = 0`).
* **Arquitectura:** Ús del patró **Singleton** per al control de la partida (`GameManager`) i la gestió de les Pools.

---

## 📊 Tipus d'Asteroides

| Tipus | Escala | Velocitat | Impactes per destruir-lo | Punts |
| :--- | :---: | :---: | :---: | :---: |
| **Petit** | 0.5 | 3 - 4 u/s | 1 | 100 |
| **Mitjà** | 1.0 | 2 - 3 u/s | 2 | 50 |
| **Gran** | 1.6 | 1 - 1.5 u/s | 4 | 20 |

---

## 🛠️ Tecnologies Utilitzades

* **Motor:** Unity 6 (2D Universal Render Pipeline)
* **Llenguatge:** C# (.NET)
* **Control de Versions:** Git / GitHub

---

## 📁 Estructura del Projecte
