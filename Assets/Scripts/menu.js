// menu
var ng = false;
var opt = false;
var ext = false;
//cam
var camera1 : Camera;
var camera2 : Camera;
//==
var back = false;
//grafoyni
var norm = false;
var high = false;
var ultra = false;

function OnMouseEnter () {
	GetComponent.<Renderer>().material.color = Color.red;
}

function OnMouseExit () {
	GetComponent.<Renderer>().material.color = Color.white;
}

function OnMouseUp () {
	if (ng == true) {
		Application.loadlevel(1);
		}
	if (opt == true) {
		camera1.enabled = false;
		camera2.enabled = true;
		}
	if (ext == true) {
		Application.Quit();
		}
	if (back == true) {
		camera2.enabled = false;
		camera1.enabled = true; 
		}
	if (norm == true) {
		QualitySettings.currentLevel = QualityLevel.Simple; 
	}
	if (high == true) {
		QualitySettings.currentLevel = QualityLevel.Beautiful; 
	}	
	if (ultra == true) {
		QualitySettings.currentLevel = QualityLevel.Fantastic; 
	}
}
