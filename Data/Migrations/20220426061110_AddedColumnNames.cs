using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employee",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Employee",
                newName: "updated_on");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Employee",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employee",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Employee",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employee",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employee",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Employee",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Employee",
                newName: "created_by");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_department_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Department",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Department",
                newName: "updated_on");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Department",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Department",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Department",
                newName: "department_name");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Department",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Department",
                newName: "created_by");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_department_id",
                table: "Employee",
                column: "department_id",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_department_id",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Employee",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Employee",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_on",
                table: "Employee",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "Employee",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Employee",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Employee",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Employee",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "Employee",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "Employee",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "Employee",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_department_id",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Department",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_on",
                table: "Department",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "Department",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Department",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "department_name",
                table: "Department",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "Department",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "Department",
                newName: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
