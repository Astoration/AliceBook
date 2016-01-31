using UnityEngine;
using System.Collections;

using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class PageStatus{
	public int AdsRank = 1;
	public int HumorRank = 1;
	public int FoodRank = 1;
	public int LoveRank = 1;
	public int ArtRank = 1;
	public int NewsRank = 1;
	public int FreindRank = 1;
	public int likes = 0;
	public int commetns = 0;
	public int money = 0;
	public int StatusPoint= 0;
}
[Serializable]
public class SaveHistory{
	public int likes;
	public int comments;
	public int margin;
}
[Serializable]
public class HistoryQue{
	public SaveHistory[] history=new SaveHistory[10];
}
[Serializable]
public class RankStatus{
	public string Name;
	public int likes;
	public int comments;
	public int margin;
	public RankStatus(string _name, int _likes, int _comments, int _margin){
		Name = _name;
		likes = _likes;
		comments = _comments;
		margin = _margin;
	}
}
[Serializable]
public class PlayerRank{
	public RankStatus[] rank = new RankStatus[10];
}
[Serializable]
public class SaveManager : MonoBehaviour {
	public static PlayerRank PlayerRankLoad(string _prefab){
		string str = PlayerPrefs.GetString (_prefab);
		if (string.IsNullOrEmpty (str))
			return null;
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream (Convert.FromBase64String (str));

		return (PlayerRank)bt.Deserialize (ms);
	}
	public static void PlayerRankSave(string _prefabName, PlayerRank _pr){
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream ();
		bt.Serialize (ms, _pr);
		PlayerPrefs.SetString (_prefabName, Convert.ToBase64String (ms.GetBuffer ()));
	}
	public static HistoryQue HistoryQueLoad(string _prefab){
		string str = PlayerPrefs.GetString (_prefab);
		if (string.IsNullOrEmpty (str))
			return null;
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream (Convert.FromBase64String (str));

		return (HistoryQue)bt.Deserialize (ms);
	}
	public static void HistoryQueSave(string _prefabName, HistoryQue _hq){
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream ();
		bt.Serialize (ms, _hq);
		PlayerPrefs.SetString (_prefabName, Convert.ToBase64String (ms.GetBuffer ()));
	}
	public static PageStatus PageSaveLoad(string _prefab){
		string str = PlayerPrefs.GetString (_prefab);
		if (string.IsNullOrEmpty (str))
			return null;
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream (Convert.FromBase64String (str));

		return (PageStatus)bt.Deserialize (ms);
	}

	public static void PageSave(string _prefabName, PageStatus _ps){
		BinaryFormatter bt = new BinaryFormatter ();
		MemoryStream ms = new MemoryStream ();
		bt.Serialize (ms, _ps);
		PlayerPrefs.SetString (_prefabName, Convert.ToBase64String (ms.GetBuffer ()));
	}
	// Use this for initialization
	void Start () {
		if (PlayerRankLoad ("rank") == null) {
			PlayerRank _prk = new PlayerRank();
			RankStatus _rnk1 = new RankStatus ("채셔 캣", 76, 76, 50000);
			RankStatus _rnk2 = new RankStatus ("이상한 주민 2", 65, 65, 47000);
			RankStatus _rnk3 = new RankStatus ("이상한 모자 장수", 61, 61, 43000);
			RankStatus _rnk4 = new RankStatus ("심각", 57, 57, 41000);
			RankStatus _rnk5 = new RankStatus ("하트 여왕", 50, 50, 37000);
			RankStatus _rnk6 = new RankStatus ("쌍둥이", 41, 41, 33000);
			RankStatus _rnk7 = new RankStatus ("문현식", 36, 36, 30000);
			RankStatus _rnk8 = new RankStatus ("애벌레", 30, 30, 23000);
			RankStatus _rnk9 = new RankStatus ("토끼", 21, 21, 13000);
			RankStatus _rnk10 = new RankStatus ("앨리스", 0, 0, 0);
			_prk.rank [0] = _rnk1;
			_prk.rank [1] = _rnk2;
			_prk.rank [2] = _rnk3;
			_prk.rank [3] = _rnk4;
			_prk.rank [4] = _rnk5;
			_prk.rank [5] = _rnk6;
			_prk.rank [6] = _rnk7;
			_prk.rank [7] = _rnk8;
			_prk.rank [8] = _rnk9;
			_prk.rank [9] = _rnk10;
			PlayerRankSave ("rank", _prk);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
