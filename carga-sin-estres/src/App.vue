<script>
import FooterContent from "@/public/pages/footer-content.component.vue";
export default {
  name: "app",
  components: {FooterContent}
}
</script>

<template>
  <div>
     <div class="main-content">
       <router-view></router-view>
     </div>
     <footer-content></footer-content>
  </div>
</template>

<style scoped>
.main-content {
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
</style>
