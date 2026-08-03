# Quy Chuẩn Đóng Góp (Contributing Guidelines)

Cảm ơn bạn đã quan tâm đến dự án **NightMare (Bóng Đêm Sau Cánh Cửa)**! Để giữ cho mã nguồn sạch sẽ, nhất quán và dễ quản lý, vui lòng tuân thủ các quy tắc đặt tên branch, viết commit và quy trình Pull Request bên dưới.

---

## 📌 1. Quy Trắc Đặt Tên Branch (Branch Naming Conventions)

Các tên branch phải tuân theo cấu trúc: `<type>/<short-description>` (dùng chữ thường, phân cách bằng dấu gạch ngang `-`).

### Các tiền tố `<type>` được phép:
- `feature/` : Thêm tính năng mới (ví dụ: `feature/oil-lamp-mechanic`, `feature/monster-ai-patrol`)
- `bugfix/`  : Sửa lỗi (ví dụ: `bugfix/basement-door-key-glitch`, `bugfix/fuse-box-audio`)
- `hotfix/`  : Sửa lỗi khẩn cấp trực tiếp trên môi trường production/release
- `refactor/`: Tối ưu hóa hoặc cấu trúc lại mã nguồn mà không đổi tính năng (ví dụ: `refactor/player-controller`)
- `docs/`    : Cập nhật tài liệu (ví dụ: `docs/update-readme`, `docs/add-contributing`)
- `style/`   : Sửa format code, khoảng trắng, không ảnh hưởng logic

### Ví dụ branch hợp lệ:
```bash
git checkout -b feature/monster-sound-effects
git checkout -b bugfix/fix-flashlight-flicker
git checkout -b docs/add-screenshot-guides
```

---

## ✍️ 2. Quy Chuẩn Viết Commit (Conventional Commits Specification)

Tất cả các thông điệp commit (commit message) phải tuân theo chuẩn **Conventional Commits**.

### Cấu trúc thông điệp commit:
```text
<type>(<scope>): <description>

[body ngắn gọn nếu cần]

[footer - ví dụ: Closes #123]
```

### Các loại `<type>` chính:
| Type | Ý nghĩa | Ví dụ |
| :--- | :--- | :--- |
| `feat` | Thêm tính năng mới | `feat(ai): integrate NavMesh agent for monster pursuit` |
| `fix` | Sửa lỗi | `fix(interact): resolve key consumption issue on basement door` |
| `docs` | Thay đổi tài liệu | `docs(readme): update game storyline and control instructions` |
| `style` | Định dạng code, dấu phẩy, khoảng trắng | `style(scripts): format FirstPersonController C# code` |
| `refactor` | Refactor mã nguồn | `refactor(system): optimize game state and trigger zone management` |
| `perf` | Tối ưu hiệu năng | `perf(lighting): optimize real-time point light performance` |
| `test` | Thêm hoặc sửa test case | `test(player): add health bar damage test` |
| `chore` | Cập nhật build script, package, không sửa code ứng dụng | `chore(deps): update Unity packages` |

### Ví dụ Commit Messages hợp lệ:
- `feat(mechanics): add oil lamp light toggle and fuel system`
- `fix(audio): fix jumpscare sound playing twice on collision`
- `docs(contributing): add Git conventional commit guidelines`
- `refactor(ai): rewrite monster pathfinding tree for efficiency`

---

## 🔀 3. Quy Trình WorkFlow & Pull Request (PR)

1. **Fork / Clone** dự án về máy cá nhân.
2. Tạo **Branch mới** từ `main` theo đúng quy chuẩn đặt tên branch.
3. Thực hiện các thay đổi và viết **Commit** theo đúng chuẩn Conventional Commit.
4. **Push** branch lên remote repository.
5. Mở **Pull Request (PR)** vào nhánh `main`:
   - Đặt tiêu đề PR rõ ràng.
   - Mô tả chi tiết những nội dung đã làm hoặc sửa đổi.
   - Đảm bảo dự án build thành công và không nảy sinh lỗi mới.

---

## 🎮 4. Quy Định Mã Nguồn Unity & C# (Code Style)

- Sử dụng chuẩn đặt tên C# chuẩn của Microsoft & Unity:
  - `PascalCase` cho tên Class, Method, Public Property.
  - `camelCase` cho private variable (hoặc `_camelCase`).
  - Đặt tên script rõ ràng theo chức năng (ví dụ: `PlayerController.cs`, `FuseBoxTrigger.cs`).
- Giữ cấu trúc thư mục Unity ngăn nắp (ví dụ: `Assets/_Project/Scripts`, `Assets/_Project/Prefabs`).

---
*Cảm ơn sự đóng góp của bạn vào thế giới kinh dị của NightMare!*
