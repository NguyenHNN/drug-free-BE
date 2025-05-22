# 🗂️ Cấu trúc thư mục dự án `DrugFree.Backend`

Dự án sử dụng kiến trúc Clean Architecture + Modular Folder. Dưới đây là mô tả ý nghĩa từng thư mục:

---

## 📁 Api/
Lớp giao tiếp với bên ngoài (UI Layer) – xử lý HTTP Request/Response.

| Thư mục con           | Mô tả |
|------------------------|-------|
| `Controllers/`         | Các endpoint API (REST) |
| `Middlewares/`         | Middleware xử lý toàn cục (Exception, Auth, v.v.) |
| `Filters/`             | Filter cho Request (Validation, Authorization logic) |
| `Configurations/`      | Cấu hình dịch vụ DI, Swagger, Policy v.v. |
| `Hubs/`                | Các SignalR hub (chat, realtime, v.v.) |

---

## 📁 Application/
Chứa logic nghiệp vụ và service interface (Application Layer).

| Thư mục con                  | Mô tả |
|------------------------------|-------|
| `Services/Interfaces/`       | Định nghĩa interface cho các service |
| `Services/Implementations/`  | Logic triển khai service |
| `DTOs/`                      | Dữ liệu request/response qua API |
| `Validation/`                | Các class FluentValidation |

---

## 📁 Domain/
Chứa các entity nghiệp vụ thuần túy, không phụ thuộc framework.

| Thư mục con    | Mô tả |
|----------------|-------|
| `Entities/`    | Entity: User, Course, Booking... |
| `Enums/`       | Enum định nghĩa loại vai trò, trạng thái... |

---

## 📁 Infrastructure/
Tầng tích hợp các dịch vụ bên ngoài như Firebase, Cloudinary, SignalR...

| Thư mục con     | Mô tả |
|-----------------|-------|
| `Firebase/`     | Xác thực người dùng qua Firebase |
| `Cloudinary/`   | Upload và xử lý ảnh |
| `SignalR/`      | Realtime chat |
| `Logging/`      | Ghi log hệ thống |

---

## 📁 Persistence/
Tầng truy cập cơ sở dữ liệu, kết nối Entity Framework Core.

| Thư mục con           | Mô tả |
|------------------------|-------|
| `Contexts/`            | `AppDbContext` quản lý DbSet và kết nối DB |
| `Configurations/`      | Fluent API cấu hình mapping entity |
| `Interfaces/`          | Interface cho UnitOfWork, Repository |
| `Implementations/`     | Repository & UnitOfWork triển khai thực tế |

---

## 📁 Core/
Chứa các class dùng chung cho toàn hệ thống.

| Thư mục con      | Mô tả |
|------------------|-------|
| `Common/`        | Response, Pagination, v.v. |
| `Constants/`     | Biến hằng số: Role, Regex, Setting... |
| `Enums/`         | Enum toàn cục |
| `Exceptions/`    | Class Exception tùy chỉnh |

---

## 📁 .github/workflows/
Cấu hình CI/CD với GitHub Actions – tự động build & test.

---

## 📄 docker-compose.yml
Chạy SQL Server container trong môi trường dev.

## 📄 README.md
Tổng quan dự án, cách chạy nhanh.

---
