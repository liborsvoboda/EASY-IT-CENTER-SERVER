//Record Audio
window.AudioContext = window.AudioContext || window.webkitAudioContext;
navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia;
window.URL = window.URL || window.webkitURL;

let onFail = function (e) {
	console.log('Rejected!', e);
};

let onSuccess = function (s) {
	let tracks = s.getTracks();
	context = new AudioContext();
	let mediaStreamSource = context.createMediaStreamSource(s);
	Gs.Variables.media.audioRecorder = new Recorder(mediaStreamSource);
	Gs.Variables.media.audioRecorder.record();

	Gs.Media.StopRecordAudio = async function () {
		Gs.Variables.media.audioRecorder.stop();
		tracks.forEach(track => track.stop());
		Gs.Variables.media.audioRecorder.exportWAV(async function (s) {
			Metro.storage.setItem("CapturedAudio", window.URL.createObjectURL(s));
		});
	}
}


/**
 * Recording Audio and save to Storage
 * @function
 */
Gs.Media.StartRecordAudio = function () {
	navigator.getUserMedia({ audio: true }, onSuccess, onFail);
}



/**
 * Start Capturing Screen Image and Save to Storage
 * @function
 */
Gs.Media.CaptureToImage = async function () {
	setTimeout(async () => {
		let EICvideoCanvas = await Gs.Media.GoToCanvas();
		Metro.storage.setItem("CapturedImage", EICvideoCanvas.toDataURL(Gs.Variables.media.imageMimeType));
	}, 500);
}


/**
 * Start Capturing Screen Video
 * @function
 */
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

/**
 * Capturing Screen Video
 * @function
 */
Gs.Media.DrawCaptureImage = function (video) {
	let EICtmpCanvas = document.createElement("canvas");
	video.width = EICtmpCanvas.width = video.videoWidth;
	video.height = EICtmpCanvas.height = video.videoHeight;
	EICtmpCanvas.getContext("2d").drawImage(video, 0, 0);
	video.srcObject.getTracks().forEach(track => track.stop());
	video.srcObject = null;
	return EICtmpCanvas;
}


/**
 *Download Captured Screen Image
 * @function
 */
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


/**
 *User Video Capturing Screen 
 * @function
 */
Gs.Media.StartUserCaptureScreen = async function (filename) {
	let mediaStream = await navigator.mediaDevices.getDisplayMedia({
		video: true,
		audio: true,
	});

	const mime = MediaRecorder.isTypeSupported("video/webm; codecs=vp9")
		? "video/webm; codecs=vp9"
		: "video/webm"
	let mediaRecorder = new MediaRecorder(mediaStream, {
		mimeType: mime
	});

	mediaRecorder.addEventListener('dataavailable', function (e) {
		Gs.Variables.media.videoData.push(e.data);
	});

	mediaRecorder.addEventListener('stop', function () {
		let blob = new Blob(Gs.Variables.media.videoData, {
			type: Gs.Variables.media.videoData[0].type
		});
		let reader = new FileReader();
		reader.onload = async function () {
			var dataURL = reader.result;
			Metro.storage.setItem("CapturedVideo", dataURL);
			await Gs.Apis.SaveUserCapturedVideo(filename);
		}
		reader.readAsDataURL(blob);

	});

	mediaRecorder.start();
}



/**
 *Public Storage Video Capturing Screen 
 * @function
 */
Gs.Media.StartPublicCaptureScreen = async function (filename) {
	let mediaStream = await navigator.mediaDevices.getDisplayMedia({
		video: true,
		audio: true,
	});

	const mime = MediaRecorder.isTypeSupported("video/webm; codecs=vp9")
		? "video/webm; codecs=vp9"
		: "video/webm"
	let mediaRecorder = new MediaRecorder(mediaStream, {
		mimeType: mime
	});

	mediaRecorder.addEventListener('dataavailable', function (e) {
		Gs.Variables.media.videoData.push(e.data);
	});

	mediaRecorder.addEventListener('stop', function () {
		let blob = new Blob(Gs.Variables.media.videoData, {
			type: Gs.Variables.media.videoData[0].type
		});
		let reader = new FileReader();
		reader.onload = async function () {
			var dataURL = reader.result;
			Metro.storage.setItem("CapturedVideo", dataURL);
			await Gs.Apis.SavePublicCapturedVideo(filename);
		}
		reader.readAsDataURL(blob);

	});

	mediaRecorder.start();
}



/**
 *Start Share Window Screen 
 * @function
 */
Gs.Media.StartShareCaptureScreen = async function () {
	try {

		Gs.Functions.RemoveClass("ShareButton", "success");
		Gs.Functions.AddClass("ShareButton", "alert");
		document.getElementById("ShareButton").innerHTML = "Stop Share Window";
		setTimeout(function () { document.getElementById("ShareButton").onclick = function () { Gs.Media.StopShareCaptureScreen(); } }, 1000);


		let videoPreview = document.getElementById('videoPreview');
		let mediaStream = await navigator.mediaDevices.getDisplayMedia(Gs.Variables.SignalR.displayMediaOptions);
		videoPreview.srcObject = mediaStream;

		Gs.Variables.SignalR.stopStreaming = false;
		setTimeout(function () { Gs.SignalR.StartVideoStream(); }, 1000);
	
	} catch (err) {
		console.error(err);
	}
}


/**
 *Stop Share Window Screen 
 * @function
 */
Gs.Media.StopShareCaptureScreen = function () {

	Gs.Functions.RemoveClass("ShareButton", "alert");
	Gs.Functions.AddClass("ShareButton", "success");
	document.getElementById("ShareButton").innerHTML = "Start Share Window";
	setTimeout(function () { document.getElementById("ShareButton").onclick = function () { Gs.Media.StartShareCaptureScreen(); } }, 1000);

	Gs.Variables.SignalR.stopStreaming = true;

	let videoPreview = document.getElementById('videoPreview');
	let tracks = videoPreview.srcObject.getTracks();
	tracks.forEach((track) => track.stop());
	videoPreview.srcObject = null;


}



/**
 *Start Capture Camera Video
 * @function
 */
Gs.Media.StartCaptureCamera = async function () {
	await navigator.mediaDevices.getUserMedia({
		video: true,
		audio: true,
	}).then(mediaStream => {

		let mediaRecorder = new MediaRecorder(mediaStream);

		Gs.Variables.media.mediaStream = mediaStream;
		Gs.Variables.media.mediaRecorder = mediaRecorder;
		let videoPreview = document.getElementById('videoPreview');
		videoPreview.srcObject = Gs.Variables.media.mediaStream;

		mediaRecorder.ondataavailable = (e) => {
			Gs.Variables.media.videoData.push(e.data);
		};

		mediaRecorder.onstop = () => {
			let reader = new FileReader();
			reader.onload = async function () {
				var dataURL = reader.result;
				Metro.storage.setItem("CapturedVideo", dataURL);
				Gs.Variables.media.videoData = [];
			}
			reader.readAsDataURL(Gs.Variables.media.videoData[0]);
		
		}

		mediaRecorder.start();
	})
 }


/**
 *Clean Captured Image from Storage
 * @function
 */
Gs.Media.ClearCapturedImage = function () {
	Metro.storage.delItem("CapturedImage");
}

/**
 *Clean Captured Video from Storage
 * @function
 */
Gs.Media.ClearCapturedVideo = function () {
	Metro.storage.delItem("CapturedVideo");
}

/**
 *Clean Captured Audio from Storage
 * @function
 */
Gs.Media.ClearCapturedAudio = function () {
	Metro.storage.delItem("CapturedAudio");
}



/**
 *Get Image From Video Element
 * @function
 */
Gs.Media.GetVideoFrame = function (videoElement) {
	const canvas = document.createElement('canvas');

	let videoPreview = document.getElementById(videoElement);
	canvas.width = videoPreview.videoWidth;
	canvas.height = videoPreview.videoHeight;
	canvas.getContext('2d').drawImage(videoPreview, 0, 0, canvas.width, canvas.height, 0, 0, canvas.width , canvas.height );
	const image = canvas.toDataURL('image/png');
	return image;
}


/**
 *Generate Image With Canvas
 * @function
 */
Gs.Media.GenerateImageWithCanvas = function (track, videoElement) {
	const canvas = document.createElement("canvas");

	const { width, height } = track.getSettings();
	canvas.width = width || 100;
	canvas.height = height || 100;

	canvas.getContext("2d")?.drawImage(videoElement, 0, 0);
	const image = canvas.toDataURL("image/png");

	return image;
}