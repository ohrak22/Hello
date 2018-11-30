## Tile Map

[Cinemachine](https://assetstore.unity.com/packages/essentials/cinemachine-79898)

[2d-extras](https://github.com/Unity-Technologies/2d-extras)
~~~
//Object prefab = PrefabUtility.GetCorrespondingObjectFromSource(go);
Object prefab = PrefabUtility.GetPrefabParent(go);
~~~

1. 타일맵 만들기.
타일맵 오브젝트 생성. GameObject > 2D Object > Tilemap 선택
팔레트 생성. Tilemap 오브젝트를 선택하고 Create New Palette 선택 후 저장.
타일 생성. 스프라이트 파일을 Palette에 드래그 앤 드롭 후 저장.
타일 그리기. Brush를 선택하고 Scene 뷰에서 타일맵을 그려본다.
* 'Shift' 키로 지우기 가능.
* '[', ']' 키로 회전 가능.

2. 충돌 처리 및 시네머신 카메라 적용.
Tilemap 오브젝트에 Tilemap Collider 2D 컴포넌트 추가.
Rigidbody 2D type Static으로 변경.
Composite Collider 2D 컴포넌트 추가.
Tilemap Collider에 Used By Composite 체크.
Cinemachine > Create 2d Camera 추가.
Cinemachine Camera를 선택한 후 Follow에 캐릭터 추가.
Cinemachine Camera Orthographic Size 조정.
캐릭터가 떨어질때도 카메라가 따라가기 때문에 Background에 Polygon Collider를 추가하고 Edit 한다.
Cinemachine Camera에서 Add Extension > Cinemachine Confiner를 추가하고 Bounding Shape 2D에 Background를 추가한다.

3. Rule Tile 만들기.
Project 창에서 Create > Tiles > Rule Tile 선택.


## Welcome to GitHub Pages

You can use the [editor on GitHub](https://github.com/ohrak22/Hello/edit/master/README.md) to maintain and preview the content for your website in Markdown files.

Whenever you commit to this repository, GitHub Pages will run [Jekyll](https://jekyllrb.com/) to rebuild the pages in your site, from the content in your Markdown files.

### Markdown

Markdown is a lightweight and easy-to-use syntax for styling your writing. It includes conventions for

```markdown
Syntax highlighted code block

# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/ohrak22/Hello/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://help.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
