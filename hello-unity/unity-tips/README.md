## TOP TIPS UNITY

1. Edit > Preferences에서 Colours > Playmode Tint 컬러를 바꿀수 있다.
2. 카메라를 선택한 상태에서 Ctrl+Shift+F를 누르면 카메라 위치를 현재 뷰 위치로 바꿀수 있다.
3. Project 창에서 검색시 Search 항목을 Asset에서 Asset Store로 바꾸면 Asset Store를 바로 검색할 수 있다.
4. 오브젝트 이동 또는 회전시 Ctrl을 누르면 스넵이 적용된다.
5. V 키를 누르고 오브젝트를 이동하면 버텍스 스넵이 가능하다. 레벨 디자인시 끝점을 맞출때 유용하다.
6. Playmode에서 component의 값을 변경하고 그 값을 저장하고 싶다면 "Copy Component" 기능을 이용해 값을 저장하고 playmode에서 나온 후 "Paste Component Value" 기능으로 값을 넣으면 된다.
7. Inspector 우측 드롭다운 메뉴에서 Debug를 선택하면 private 필드를 확인 할 수 있다.
8. Range Attribute
~~~
[Range(0.1f, 2.0f)]
public float pitch = 0.1f;
~~~
9. Space & Header Attribute
~~~
[Header("Transform")]
public Vector3 position;
public Vector3 rotation;
public Vector3 scale;

[Space]

[Header("Properties")]
public string objectName;
public int objectCount;
public float objectWeight;
~~~
10. HideInInspector
~~~
[HideInInspector]
public int secret = 42;
~~~
11. SerializeField
~~~
[SerializeField]
private float health = 100f;
~~~
