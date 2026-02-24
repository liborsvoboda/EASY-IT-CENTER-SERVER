//Record Audio

window.AudioContext = window.AudioContext || window.webkitAudioContext;
navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia;
window.URL = window.URL || window.webkitURL;
let audioRecorder;

let onFail = function (e) {
	console.log('Rejected!', e);
};

let onSuccess = function (s) {
	let tracks = s.getTracks();
	context = new AudioContext();
	let mediaStreamSource = context.createMediaStreamSource(s);
	audioRecorder = new Recorder(mediaStreamSource);
	audioRecorder.record();

	Gs.Media.StopRecordAudio = async function () {
		audioRecorder.stop();
		tracks.forEach(track => track.stop());
		audioRecorder.exportWAV(async function (s) {
			Metro.storage.setItem("CapturedAudio", window.URL.createObjectURL(s));
		});
	}
}


Gs.Media.StartRecordAudio = function () {
	navigator.getUserMedia({ audio: true }, onSuccess, onFail);
}


//Start Capturing Screen Image
Gs.Media.CaptureToImage = async function () {
	setTimeout(async () => {
		let EICvideoCanvas = await Gs.Media.GoToCanvas();
		Metro.storage.setItem("CapturedImage", EICvideoCanvas.toDataURL(Gs.Variables.media.imageMimeType));
	}, 500);
}


Gs.Media.GoToCanvas = async function () {
	let EICtmpStream = await navigator.mediaDevices.getDisplayMedia({ video: true });
	let EICtmpVideo = document.createElement("video");
	EICtmpVideo.srcObject = EICtmpStream;
	EICtmpVideo.play();

	return new Promise(resolve => {
		EICtmpVideo.addEventListener("canplay", e => {
			let EICtmpCanvas = Gs.Media.DrawCaptureImage(EICtmpVideo);
			resolve(EICtmpCanvas);
		}, { once: true });
	});
}


Gs.Media.DrawCaptureImage = function (video) {
	let EICtmpCanvas = document.createElement("canvas");
	video.width = EICtmpCanvas.width = video.videoWidth;
	video.height = EICtmpCanvas.height = video.videoHeight;
	EICtmpCanvas.getContext("2d").drawImage(video, 0, 0);
	video.srcObject.getTracks().forEach(track => track.stop());
	video.srcObject = null;
	return EICtmpCanvas;
}


Gs.Media.CaptureCameraToVideo = async function () {
	if (Gs.Variables.media.mediaRecorder == null) {
		try {
			const stream = await navigator.mediaDevices.getUserMedia(Gs.Variables.media.videoCaptureOpt);
			Gs.Media.HandleStreamSuccess(stream);
		} catch (e) {
			//Gs.Variables.media.EICconsole = 'navigator.getUserMedia error: ' + e + "\r\n" + Gs.Variables.media.EICconsole;
		}
	} else {
		Gs.Variables.media.mediaRecorder.stop();
		let tracks = Gs.Variables.media.videoCaptureStream.getTracks();
		tracks.forEach(track => { track.stop(); });
	}
}


Gs.Media.CaptureScreenToVideo = async function () {
	//if (Gs.Variables.media.mediaRecorder == null) {
	if (Metro.storage.getItem("CapturedVideo", null) == null) {
		try {
			const stream = await navigator.mediaDevices.getDisplayMedia(Gs.Variables.media.videoCaptureOpt);
			Gs.Media.HandleStreamSuccess(stream);
		} catch (e) {
			//Gs.Variables.media.EICconsole = 'navigator.getUserMedia error: ' + e + "\r\n" + Gs.Variables.media.EICconsole;
		}
	} else {
		Gs.Variables.media.mediaRecorder.stop();
		let tracks = Gs.Variables.media.videoCaptureStream.getTracks();
		tracks.forEach(track => { track.stop(); });
	}
}


Gs.Media.HandleDataAvailable = function (event) {
	if (event.data && event.data.size > 0) {
		Gs.Variables.media.videoRecBlob.push(event.data);
		Metro.storage.setItem("CapturedVideo", new Blob(Gs.Variables.media.videoRecBlob, { type: Gs.Variables.media.videoMimeType }));
	}
}


Gs.Media.HandleStreamSuccess = function (stream) {
	Gs.Variables.media.videoCaptureStream = stream;
	try {
		let options = Gs.Variables.media.videoMimeType;
		Gs.Variables.media.mediaRecorder = new MediaRecorder(Gs.Variables.media.videoCaptureStream, { options });
	} catch (e) {
		//Gs.Variables.media.EICconsole = 'Exception while creating MediaRecorder: ' + e + "\r\n" + Gs.Variables.media.EICconsole;
		return;
	}
	Gs.Variables.media.mediaRecorder.ondataavailable = Gs.Variables.media.HandleDataAvailable;
	Gs.Variables.media.mediaRecorder.start();
}


Gs.Media.DownloadCapturedVideo = function () {
	const EICdownloadUrl = window.URL.createObjectURL(Metro.storage.getItem("CapturedVideo",null));
	const a = document.createElement('a');
	a.style.display = 'none';
	a.href = EICdownloadUrl;
	a.download = "ScreenShot.mp4";
	a.mimeType = Gs.Variables.media.videoMimeType;
	document.body.appendChild(a);
	a.click();
	setTimeout(() => {
		document.body.removeChild(a); window.URL.revokeObjectURL(EICdownloadUrl);
	}, 100);
}


Gs.Media.DownloadCapturedVideoName = function (fileName) {
	const EICdownloadUrl = window.URL.createObjectURL(Metro.storage.getItem("CapturedVideo", null));
	const a = document.createElement('a');
	a.style.display = 'none';
	a.href = EICdownloadUrl;
	a.download = fileName + ".mp4";
	a.mimeType = Gs.Variables.media.videoMimeType;
	document.body.appendChild(a);
	a.click();
	setTimeout(() => {
		document.body.removeChild(a); window.URL.revokeObjectURL(EICdownloadUrl);
	}, 100);
}

Gs.Media.DownloadCapturedImage = function () {
	const a = document.createElement('a');
	a.style.display = 'none';
	a.href = Metro.storage.getItem("CapturedImage", null);
	a.download = "ScreenShot.png";
	document.body.appendChild(a);
	a.click();
	setTimeout(() => {
		document.body.removeChild(a);
	}, 100);
}


Gs.Media.ClearCapturedImage = function () {
	Metro.storage.delItem("CapturedImage");
}

Gs.Media.ClearCapturedVideo = function () {
	Metro.storage.delItem("CapturedVideo");
}

Gs.Media.ClearCapturedAudio = function () {
	Metro.storage.delItem("CapturedAudio");
}