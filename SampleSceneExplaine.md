<div dir='rtl' lang='he'>

## קישור למשחק
https://talabed.itch.io/maze-runner-game-sample
## מטרה
על השחקן לאסוף את ביצת הדרקון הממוקמת במבוך ולהביא אותה למקומה המיועד בקרחת.

## תיאור סקריפטים
* [CharacterKeyboardMover](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CharacterKeyboardMover.cs) - שימש במקור לתזוזת השחקן. כרגע לא בשימוש.
* [Chaser](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/Chaser.cs) - מאפשר לאובייקט המשתמש בו לרדוף אחרי אובייקט אחר (ישמש בעתיד בכדי שמפלצות ירדפו אחרי השחקן)
* [CollideMonster](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CollideMonster.cs) - גורם לכך שכאשר השחקן נפגע ממפלצת הוא יתחיל את השלב מחדש והניקוד שלו יאותחל לניקוד שהיה לו בתחילת אותו שלב.
* [CursorHider](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/CursorHider.cs) - גורם לכך שהעכבר ייעלם עד אשר השחקן ילחץ ESC.
* [GoToLevel2](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/GoToLevel2.cs) - מעביר את השחקן לשלב 2 אם צבר מספיק נקודות
* [LookX](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/LookX.cs) - שולט על תנועת המצלמה על ידי העכבר בציר הX.
* [LookY](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/LookY.cs) - שולט על תנועת המצלמה על ידי העכבר בציר הY.
* [MonsterIdle](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/MonsterIdle.cs) - משאיר את אנימציית המפלצת במצב Idle באופן קבוע.
* [MonsterWalk](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/MonsterWalk.cs) - משאיר את אנימציית המפלצת במצב Walking באופן קבוע.
* [OscillatorMovement](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/OscillatorMovement.cs) - גורם למי שמחזיק בו לנוע בתנועת מטוטלת קבועה.
* [PlaceObject](https://github.com/TA-GAMES/MyMazeRunner/blob/main/Assets/Scripts/PlaceObject.cs) - כאשר מזהה התנגשות, חושף אובייקט מוסתר (משמש לצורך הצבת הביצה במקומה לאחר שהשחקן אוסף אותה).

</div>
