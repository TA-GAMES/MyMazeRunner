<div dir='rtl' lang='he'>

## קישור למשחק
https://talabed.itch.io/maze-runner-game-sample
## מטרה
בכל שלב על השחקן להשלים את המשימה המוצגת לו בתחילת השלב בכדי להשלים את השלב ולעבור לשלב הבא.

## תיאור סקריפטים
* [ApplesScore](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/ApplesScore.cs) - מדד ניקוד לאסיפת תפוחים
* [CamSeeThroughtWalls](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CamSeeThroughtWalls.cs) - גורם לכך שהחומות לא יסתירו את המצלמה
* [Chaser](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/Chaser.cs) - מאפשר לאובייקט לרדוף אחרי אובייקט אחר (מאפשר למפלצת שמקבלת אותו לרדוף אחרי השחקן)
* [CollideMonster](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CollideMonster.cs) - גורם לכך שכאשר שחקן יתנגש במפלצת יעלה על המסך פאנל המיידע אותו שהוא מת.
* [CursorHider](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CursorHider.cs) - גורם לכך שהעכבר ייעלם עד אשר השחקן ילחץ ESC.
* [GoToNextLevel](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/GoToNextLevel.cs) - מחזיק את הפונקציה loadNextLevel() המאפסת את הפרמטרים בסיום כל שלב.
* [KillMonster](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/KillMonster.cs) - מאפשר לשחקן להרוג מפלצת (בהתאם לתנאים מסוימים בכל שלב).
* [KnifeScore](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/KnifeScore.cs) - מדד ניקוד לאסיפת סכינים.
* [LevelManager](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/LevelManager.cs) - כאן נקבע מה הנתאים הנדרשים על מנת לעבור כל שלב. טוען את מסך ההסבר בתחילת השלב ואת המסך שמודיע שהשלב הושלם בסוף השלב (לאחר שמסך זה יעלה תיטען גם הפונקציה המעבירה לשלב הבא).
* [LookX](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/LookX.cs) - שולט על תנועת המצלמה על ידי העכבר בציר הX.
* [LookY](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/LookY.cs) - שולט על תנועת המצלמה על ידי העכבר בציר הY.
* [MonsterIdle](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/MonsterIdle.cs) - משאיר את אנימציית המפלצת במצב Idle באופן קבוע.
* [MonsterWalk](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/MonsterWalk.cs) - משאיר את אנימציית המפלצת במצב Walking באופן קבוע.
* [OpenGateToNextLevel](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/OpenGateToNextLevel.cs) - פותח שער שמעבר דרכו מסיים שלב.
* [OscillatorMovement](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/OscillatorMovement.cs) - גורם למי שמחזיק בו לנוע בתנועת מטוטלת קבועה.
* [PlaceObject](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/PlaceObject.cs) - כאשר מזהה התנגשות, חושף אובייקט מוסתר (משמש לצורך הצבת הביצה במקומה לאחר שהשחקן אוסף אותה).
* [PlayerCollect](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/PlayerCollect.cs) - אובייקט שמחזיק בסקריפט הזה יהיה ניתן לאסיפה על ידי השחקן.
* [PlayerMoveControl](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/PlayerMoveControl.cs) - שולט על תנועת השחקן. למעשה מה שמזיז את השחקן זה מצב האנימציה בו הוא נמצא בכל פעם. לחיצה על W או חץ למעלה מקדמת אותו קדימה, לחיצה על A,D או חץ ימינה, חץ שמאלה מאפשרת לו להסתובב לצד אותו הוא בחר. לחיצה על LEFT SHIFT יחד עם W או חץ למעלה מאפשרת לשחקן לרוץ.
* [RestartLevel](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/RestartLevel.cs) - מחזיק בפונקציה startOver() שטעינה שלה בסרט האנימציה טוענת את השלב מחדש (כולל איפוס ניקוד ופרמטרים נוספים).
* [ScoreScript](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/ScoreScript.cs) - שולט על ניקוד השחקן. לשחקן יש גם ניקוד כולל שנצבר לאורך המשחק וגם ניקוד לכל שלב (מוסתר מהשחקן) שלפיו נקבע מתי הוא יכול להמשיך לשלב הבא.
* [Timer](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/Timer.cs) - שולט בזמן בו ניתן להשלים כל שלב.

</div>
