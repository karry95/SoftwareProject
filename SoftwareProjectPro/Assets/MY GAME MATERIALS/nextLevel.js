// JavaScript source code

var newScene : String;

function onTriggerEnter(Col : Collider){
    if(Col.CompareTag("Player")){
        Application.LoadLevel(newScene);
    }
}
