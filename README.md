# OpenCV for Unity

Use of OpenCV for Unity package to perform object detection

    OpenCV v.2.4.7
    same API as OpenCV Java 4.5.5
    Build Android : API level 24 or later
    Build iOS : iOS Version 9.0 or later

The OpenCV for Unity plugin allows to use just up to YoloV4 models, requiring a pair of .cfg and .wts files as input.    

## Get latest version (Editor only)

https://enoxsoftware.com/opencvforunity/get_asset/


## How to set a new YOLOv4 model

To use a trained YOLOv4 model with OpenCV, you will need the following files:

1. The YOLOv4 configuration file: This file contains the network architecture, including the number of layers, filters, and classes, as well as the anchors used for object detection. The file is typically named "yolov4.cfg".

2. The YOLOv4 weights file: This file contains the learned parameters of the network. The file is typically named "yolov4.weights".

3. The YOLOv4 classes file: This file contains the names of the classes that the model was trained to detect. The file is typically named "coco.names" for the standard YOLOv4 model, which is trained on the Common Objects in Context (COCO) dataset.

You can download the YOLOv4 configuration file and the pre-trained weights file from the official Darknet website. The YOLOv4 classes file can also be found on the Darknet website or you can create your own file with your own classes.

The official website for the Darknet framework is https://pjreddie.com/darknet/. 

## Where to find YOLOv4 models

You can find YOLOv4 example models trained on food datasets in several places. Here are some options:

1. Darknet: YOLOv4 is developed in Darknet framework and the official repository has pre-trained models, including a food model trained on the Food101 dataset. You can download the model and use it with OpenCV by following the instructions in the Darknet documentation.

2. TensorFlow Hub: TensorFlow Hub offers a pre-trained YOLOv4 model that you can use with OpenCV. The model is trained on the COCO dataset, which includes a food category.

3. Model Zoo: The Model Zoo repository on GitHub has several YOLOv4 models trained on food datasets, including a model trained on the Food-101 dataset and another trained on the UEC-Food-256 dataset. You can download the weights file and use it with OpenCV.


## Youtube

    https://www.mecharithm.com/how-to-install-the-opencv-sdk-in-unity/

    https://www.youtube.com/watch?v=U8CS5LSnp9w&ab_channel=Mecharithm-RoboticsandMechatronics

    MP4 Video as a Virtual Webcam - Tutorial
    https://www.youtube.com/watch?v=hKLH_V4qE_0

## Android Build

Gradle Build needs gradle-6.9.3 (fails with 7.x)

## OBS

    Works with the following:

    - Scene: YoloObjectDetectionWebCam
    - obs-virtualcam-2.0.5-Windows-installer
    - OBS-Studio-27.1.3-Full-Installer-x64


## For examples to work:

For each example, import stuff as described in Assets/StreamingAssets/dnn/setup_dnn_module.pdf

WebCamTextureToMatHelper:

    Requested Device Name: HD 720P Webcam
    Requested Width: 1920
    Requested Height: 1080

## Working Examples

Scene: TensorFlowInceptionWebCam.unity

    Use webcam for object detection

Scene: YoloObjectDetectionWebCam.unity

    Webcam and yolo-v4-tiny model
    Assets/StreamingAssets/dnn/coco.names: 80 items

    
