using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class SomeUsersMayNotHaveAMedicalConditionAndAddedUniqueConstrainsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalConditions_MedicalConditionId",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "Patients",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalConditions_Name",
                table: "MedicalConditions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialities_Name",
                table: "DoctorSpecialities",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalConditions_MedicalConditionId",
                table: "Patients",
                column: "MedicalConditionId",
                principalTable: "MedicalConditions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalConditions_MedicalConditionId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_MedicalConditions_Name",
                table: "MedicalConditions");

            migrationBuilder.DropIndex(
                name: "IX_DoctorSpecialities_Name",
                table: "DoctorSpecialities");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "Patients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalConditions_MedicalConditionId",
                table: "Patients",
                column: "MedicalConditionId",
                principalTable: "MedicalConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
