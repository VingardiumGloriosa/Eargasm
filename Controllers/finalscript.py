import csv
import numpy as np
import sys
import pandas as pd
from sklearn.preprocessing import MinMaxScaler
from numpy.core.fromnumeric import shape
from keras.models import Sequential
from keras.layers import Dense, LSTM, Dropout
from tensorflow.keras.optimizers import Adam
from tensorflow import keras
import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

CLIENT_ID = '7d14d7a75a87422d98c2cbbdce52d31e'
CLIENT_SECRET = '0fde8d452c0a4fc8908a8f379f12fb27'
username = "21n37prne5zlleh5pxfkpgspq"
model = keras.models.load_model(
    r'C:\Users\Glória\Code\GitHub\Sem 4\CryingMaterial\Eargasm\Controllers\acousticnesshandpicked.h5')
OUTPUT_FILE_NAME = r"C:\Users\Glória\Code\GitHub\Sem 4\CryingMaterial\Eargasm\testfunctionality.csv"
newPlaylist = []
playlistDict = {}
sortedPlaylistName = sys.argv[2]

IMG_FILE_NAME = "imgUrl.csv"

# new authentication for user (used to be just session but to do shit with users we need to authenticate them specifically)
# this is also better authentication in general as it allows for more options while authenticating like speciffic scopes, redirects, etc.
token = spotipy.util.prompt_for_user_token(
    username=username,
    scope='playlist-modify-public playlist-modify-private',
    client_id=CLIENT_ID,
    client_secret=CLIENT_SECRET,
    redirect_uri="http://localhost:5123/callback"
)
sp = spotipy.Spotify(auth=token)

playlist_uri = sys.argv[1]

# get list of tracks in a given playlist (note: max playlist length 100)
tracks = sp.playlist_tracks(playlist_uri)["items"]
playlist = sp.playlist_cover_image(playlist_uri)
print(playlist)
# print(type(tracks))

# create the img url file TEMPORARY SOLUTION
with open(IMG_FILE_NAME, "w", encoding="utf-8") as file:  # w rewrite, a append
    writer = csv.writer(file)
    # extract name and artist
    for track in tracks:
        playlistCover = playlist[0]["url"]
        writer.writerow([playlistCover])

# create csv file
with open(OUTPUT_FILE_NAME, "w", encoding="utf-8") as file:  # w rewrite, a append
    writer = csv.writer(file)

    # write header column names
    writer.writerow(["track", "id", "danceability", "energy", "key", "loudness", "speechiness",
                    "acousticness", "instrumentalness", "liveness", "valence", "tempo", "coverlink"])

    # extract name and artist
    for track in tracks:
        # print(track)
        name = track["track"]["name"]
        id = track["track"]["id"]
        features = sp.audio_features(id)
        danceability = features[0]["danceability"]
        energy = features[0]["energy"]
        key = features[0]["key"]
        loudness = features[0]["loudness"]
        speechiness = features[0]["speechiness"]
        acousticness = features[0]["acousticness"]
        instrumentalness = features[0]["instrumentalness"]
        livenesss = features[0]["liveness"]
        valence = features[0]["valence"]
        tempo = features[0]["tempo"]
        playlistCover = playlist[0]["url"]

        # write to csv
        writer.writerow([name, id, danceability, energy, key, loudness, speechiness,
                        acousticness, instrumentalness, livenesss, valence, tempo, playlistCover])


dataset_train = pd.read_csv(OUTPUT_FILE_NAME)
originalPlaylist = dataset_train.iloc[:, 1:2].values
training_set = dataset_train.iloc[:, 7:8].values  # return numpy arr
working_set = dataset_train.iloc[:5, 7:8]

#user_playlist_create(user, name, public=True, collaborative=False, description='')
sp.user_playlist_create(username, sortedPlaylistName)
playlists = sp.user_playlists(username)["items"]

for playlist in playlists:
    playlistName = playlist["name"]
    playlistID = playlist["id"]
    playlistDict[playlistName] = playlistID

for i in range(training_set.size):
    prediction = model.predict(working_set)
    print(prediction)
    idx = (np.abs(training_set - prediction[4])).argmin()
    # print(np.int64(idx).item())
    print(originalPlaylist.item(idx))
    temp = np.append(working_set, [training_set[idx]], axis=0)
    working_set = temp[1:]
    print(working_set)
    newPlaylist.append(originalPlaylist.item(idx))
    training_set = np.delete(training_set, idx, axis=0)
    originalPlaylist = np.delete(originalPlaylist, idx, axis=0)
    # print(working_set)

# print(newPlaylist)
#user_playlist_add_tracks(user, playlist_id, tracks, position=None)
sp.user_playlist_add_tracks(
    username, playlistDict[sortedPlaylistName], newPlaylist, position=None)

#user_playlist_create(user, name, public=True, collaborative=False, description='')
#sp.user_playlist_create(username, "sorted")
