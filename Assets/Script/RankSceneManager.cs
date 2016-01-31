using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RankSceneManager : SaveManager {
	public Text[] group;
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

		PlayerRank _rnk = PlayerRankLoad ("rank");

		for (int i = 0; i < 40; i++) {
			if (i % 4 == 0) {
				group [i].text = _rnk.rank [9 - i / 4].Name.ToString ();
			}
			if (i % 4 == 1) {
				group [i].text = _rnk.rank [9 - i / 4].likes.ToString ();
			}
			if (i % 4 == 2) {
				group [i].text = _rnk.rank [9 - i / 4].comments.ToString ();
			}
			if (i % 4 == 3) {
				group [i].text = _rnk.rank [9 - i / 4].margin.ToString ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
